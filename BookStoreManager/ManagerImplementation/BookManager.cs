using BookStoreCommonLayer;
using BookStoreManager.ManagerInterfaces;
using BookStoreRepository.RepositoryImplementation;
using BookStoreRepository.RepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManager.ManagerImplementation
{
   public class BookManager : IBookManager
    {
        private readonly IAddBookRepository addBookRepository;
        public BookManager(IAddBookRepository addBook)
        {
            this.addBookRepository = addBook;
        }
        public Task<string> AddBook(AddBookModel addBookModel)
        {
            var addbook = this.addBookRepository.AddBook(addBookModel);
            return addbook;
        }

        public int CountBook()
        {
            var bookcount = this.addBookRepository.CountBook();
            return bookcount;
        }

        public Task Delete(int id)
        {
            return this.addBookRepository.Delete(id);
        }

        public List<AddBookModel> Getbook()
        {
            var resbook = this.addBookRepository.Getbook();
            return resbook;
        }

        public async Task<string> UploadImg(int bookId, string image)
        {
            var images = await this.addBookRepository.UploadImg(bookId, image);
            return images;
        }
    }
}
