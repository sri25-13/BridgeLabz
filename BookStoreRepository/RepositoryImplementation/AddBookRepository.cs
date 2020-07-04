using BookStoreCommonLayer;
using BookStoreRepository.BookStoreContext;
using BookStoreRepository.RepositoryInterfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepository.RepositoryImplementation
{
  public  class AddBookRepository : RepositoryInterfaces.IAddBookRepository
    {
        private readonly Context context;
        private readonly IConfiguration configuration;
        public AddBookRepository(Context userContext, IConfiguration config)
        {
            this.context = userContext;
            this.configuration = config;
        }

        public async Task<string> AddBook(AddBookModel addBookModel)
        {
            AddBookModel addbook = new AddBookModel()
            {
                BookId = addBookModel.BookId,
                BookTitle = addBookModel.BookTitle,
                BookDescription = addBookModel.BookDescription,
                BookPrice = addBookModel.BookPrice,
                BookImage = addBookModel.BookImage,
                Author = addBookModel.Author,
                BooksCount = addBookModel.BooksCount,
            };
            var add = this.context.Books.AddAsync(addbook);
            var addreturn = context.SaveChangesAsync();
            await Task.Run(() => addreturn);
            return "New book added to store";
        }

        public int CountBook()
        {
            var result = this.context.Books.ToList();
            return result.Count;
        }

        public Task Delete(int bookId)
        {
            var result = this.context.Books.Where(option => option.BookId == bookId).FirstOrDefault();
            if (result != null)
            {
                this.context.Books.Remove(result);
            }
            return Task.Run(() => context.SaveChanges());
        }

        public List<AddBookModel> Getbook()
        {
            return this.context.Books.ToList();
        }


        public async Task<string> UploadImg(int bookId, string image)
        {
            try
            {
                var name = image;
                Account account = new Account(configuration["Cloudinary:CloudName"], configuration["Cloudinary:Key"], configuration["Cloudinary:Secret"]);
                Cloudinary cloudinary = new Cloudinary(account);
                var UploadFile = new ImageUploadParams()
                {
                    File = new FileDescription(name)
                };
                var Imageresult = cloudinary.Upload(UploadFile);

                var res = this.context.Books.Where(option => option.BookId == bookId).SingleOrDefault();
                if (res != null)
                {
                    res.BookImage = Imageresult.Url.ToString();
                    this.context.Books.Update(res);
                    await Task.Run(() => context.SaveChanges());
                    return "Image uploaded successfully";
                }
                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}