using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BLL.Services
{
    public class ContactService
    {
        DataBaseContext database = new DataBaseContext();

        /// دریافت لیست مخاطبین
        public List<ContactListDto> GetContactLists()
        {
            var contacts = database.Contacts.Select(p => new ContactListDto()
            {
                FullNumber = $"{p.Name} {p.LastName}"  ,
                PhoneNumber = p.PhoneNumber,
                Id = p.Id,
            }).ToList();
            return contacts;
        }
        /// <summary>
        /// جستوجو
        /// </summary>
        /// <param name="SearchKey"></param>
        /// <returns></returns>
        public List<ContactListDto> SearchContant(string SearchKey)
        {
            var ContacttQuery = database.Contacts.AsQueryable();
            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContacttQuery = ContacttQuery.Where(p =>
                p.Name.Contains (SearchKey)
                ||  p.LastName.Contains (SearchKey)  
                ||  p.PhoneNumber.Contains (SearchKey) 
                ||  p.Company.Contains (SearchKey)
                );

                //ContacttQuery = ContacttQuery.Where(p => p.LastName.Contains(SearchKey));
                //ContacttQuery = ContacttQuery.Where(p => p.PhoneNumber.Contains(SearchKey)
                //    || p.Company.Contains(SearchKey));

            }
            var data = ContacttQuery.Select(p => new ContactListDto()
            {
                FullNumber = $"{p.Name} {p.LastName}"  ,
                PhoneNumber = p.PhoneNumber,
                Id = p.Id,
            }).ToList();
            return data;
        }

        public ReasultDto DeleteContact(int Id)
        {
            var contact = database.Contacts.Find(Id);
            if (contact != null)
            {
                database.Remove(contact);
                database.SaveChanges();
                return new ReasultDto
                {
                    IsSuccess = true,
                    Message = "مخاطب با موفقیت حذف شد"
                };
            }
            return new ReasultDto
            {
                IsSuccess = false,
                Message = "مخاطب یافت نشد"
            };
        }
        public ReasultDto<ContactDetailDto>GetContactDetatil(int Id)
        {
            var contact = database.Contacts.Find(Id);
            if (contact == null)
            {
                return new ReasultDto<ContactDetailDto>()
                {
                    IsSuccess = false,
                    Message = " مخاطب یافت نشد",
                    Data = null,
                };
            }
            var data = new ContactDetailDto()
            {
                Company = contact.Company,
                CreateAt = contact.CreateAt,
                Description = contact.Description,
                PhoneNumber = contact.PhoneNumber,
                Id = contact.Id,
                LastName= contact.LastName,
                Name = contact.Name,
            };
            return new ReasultDto<ContactDetailDto>()
            {
                Data = data,
                IsSuccess = true,
            };
        }
        public ReasultDto AddNewContact(AddNewContactDto newContact)
        {
            if (string.IsNullOrEmpty(newContact.PhoneNumber))
            {
                return new ReasultDto()
                {
                    IsSuccess=false,
                    Message="شماره تلفن اجباری می باشد"
                };
            }

            Contact contact = new Contact()
            {
                Company = newContact.Company,
                CreateAt = DateTime.Now,
                Description = newContact.Description,
                PhoneNumber = newContact.PhoneNumber,
                Name = newContact.Name,
                LastName = newContact.LastName,
            };
            database.Contacts.Add(contact);
            database.SaveChanges();
            return new ReasultDto()
            {
                IsSuccess = true,
                Message = $"مخاطب {contact.Name} {contact.LastName} مخاطب با موفقیت ذخیره شد"
            };
        }
        public ReasultDto EditContact(EditContactDto editContactDto)
        {
            var contact = database.Contacts.Find(editContactDto.Id);
            if (contact == null)
            {
                return new ReasultDto()
                {
                    IsSuccess=false,
                    Message="مخاطب پیدا نشد"
                };
            }
            contact.Company = editContactDto.Company;
            contact.Name = editContactDto.Name;
            contact.LastName = editContactDto.LastName;
            contact.Description = editContactDto.Description;
            contact.PhoneNumber = editContactDto.PhoneNumber;


            database.SaveChanges();
            return new ReasultDto()
            {
                IsSuccess = true,
                Message = " اطلاعات مخاطب با موفقیت ویرایش شد",
            };
        }
    }
}
