using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Viking.Api.Models;
using Viking.Data.Models.Entities;
using Viking.Data.Models.Entities.Services;
using Viking.Data.Models.ViewModels;

namespace Viking.Api.Controllers.ApiControllers
{
    public class CustomerApiController : ApiController
    {
        //This method uses for authenticating users when they log in to the system
        [HttpPost]
        [Route("api/customer/CheckUserLogin")]
        public HttpResponseMessage CheckUserLogin(string accountId, string password)
        {
            try
            {
                var accountService = this.Service<IAccountService>();
                var accounts = accountService.FindUserByIdAndPassword(accountId, password);

                if (accounts != null && accounts.Any())
                {
                    var account = accounts.ProjectTo<AccountViewModel>(this.AutoMapperConfig).FirstOrDefault();

                    return new HttpResponseMessage()
                    {
                        Content = new JsonContent(account)
                    };
                }

                return new HttpResponseMessage()
                {
                    Content = new JsonContent(0)
                };
            }
            catch (Exception e)
            {
                return new HttpResponseMessage()
                {
                    Content = new JsonContent(e.Message)
                };
            }
        }

        //Create new customer and contact
        [HttpPost]
        [Route("api/customer/CreateNewCustomerAndContact")]
        public HttpResponseMessage CreateNewCustomerAndContact(
            string name, string identityCard, string phone, string address, string email,
            string company, string position, int stageId)
        {
            try
            {
                var customerService = this.Service<ICustomerService>();
                var contactService = this.Service<IContactService>();

                //create new customer
                tbl_Customer customer = new tbl_Customer();
                customer.CusName = name;
                customer.CusCMND = identityCard;
                customer.CusPhone = phone;
                customer.CusAddress = address;
                customer.CusEmail = email;
                customer.CusCompany = company;
                customer.CusPosition = position;

                customerService.add(customer);

                //create new contact
                tbl_Contact contact = new tbl_Contact();
                contact.dateStart = DateTime.Now;
                contact.lastUpdate = DateTime.Now;
                contact.cusID = customer.CusId;
                contact.stageID = stageId;

                contactService.add(contact);

                return new HttpResponseMessage()
                {
                    Content = new JsonContent(new CustomerContactViewModel(customer, contact))
                };
            }
            catch (Exception e)
            {
                return new HttpResponseMessage()
                {
                    Content = new JsonContent(e.Message)
                };
            }
        }

        //Search customer info by inputting keyword
        [HttpPost]
        [Route("api/customer/SearchCustomerInfo")]
        public HttpResponseMessage SearchCustomerInfo(string keyword)
        {
            try
            {
                var customerService = this.Service<ICustomerService>();
                var contactService = this.Service<IContactService>();

                var listCustomers = customerService.getAllCustomers().AsEnumerable();
                var listContacts = contactService.getAllContact().AsEnumerable();

                //Validation keyword
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    //Search by keyword
                    listCustomers = listCustomers.Where(a => 
                        StringConvert.EscapeName(a.CusName).ToLower().Contains(StringConvert.EscapeName(keyword).ToLower()));

                    var listCustomersWithStageId = listCustomers.Join(listContacts,
                                                                customer => customer.CusId,
                                                                contact => contact.cusID,
                                                                (customer, contact) => new {
                                                                    cusId = customer.CusId,
                                                                    cusName = customer.CusName,
                                                                    phone = customer.CusPhone,
                                                                    stageId = contact.stageID.GetValueOrDefault()
                                                                });

                    return new HttpResponseMessage()
                    {
                        Content = new JsonContent(listCustomersWithStageId)
                    };
                }

                return new HttpResponseMessage()
                {
                    Content = new JsonContent(null)
                };
            }
            catch (Exception e)
            {
                return new HttpResponseMessage()
                {
                    Content = new JsonContent(e.Message)
                };
            }
        }

        [HttpPost]
        [Route("api/customer/FindCustomerById")]
        public HttpResponseMessage FindCustomerById(int cusId)
        {
            try
            {
                var customerService = this.Service<ICustomerService>();
                var contactService = this.Service<IContactService>();
                if (cusId != null)
                {
                    var foundCustomer = customerService.GetCustomerById(cusId);
                    if (foundCustomer != null)
                    {
                        var listContacts = contactService.getAllContact().AsEnumerable();

                        var customerInfo = listContacts.Where(a => a.cusID == foundCustomer.CusId)
                            .Select(b => new CustomerViewModel(foundCustomer, b.stageID));

                        return new HttpResponseMessage()
                        {
                            Content = new JsonContent(customerInfo)
                        };
                    }
                }

                return new HttpResponseMessage()
                {
                    Content = new JsonContent(null)
                };
            }
            catch (Exception e)
            {
                return new HttpResponseMessage()
                {
                    Content = new JsonContent(e.Message)
                };
            }
        }

        #region AutoMapperConfig
        public IConfigurationProvider AutoMapperConfig
        {
            get
            {
                return this.Service<IConfigurationProvider>();
            }
        }
        #endregion
    }
}
