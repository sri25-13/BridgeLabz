using BookStoreCommonLayer;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManager.ManagerInterfaces
{
   public interface IBookManager
    {
        Task<string> AddBook(AddBookModel addBookModel);
        Task<string> UploadImg(int bookId, string image);
        Task Delete(int id);
        int CountBook();
        List<AddBookModel> Getbook();
    }
}
