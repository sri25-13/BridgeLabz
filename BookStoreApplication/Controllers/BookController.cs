using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreCommonLayer;
using BookStoreManager.ManagerInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookManager addBookManager;
        public BookController(IBookManager addBook)
        {
            this.addBookManager = addBook;
        }
        [HttpPost("AddBook")]
        public async Task<IActionResult> Addbook([FromBody] AddBookModel addBookModel)
        {
            try
            {
                var result = await this.addBookManager.AddBook(addBookModel);
                if (result != null)
                {
                    return Ok(new { result });
                }
                else
                {
                    var json = new Jsonmodel();
                    json.ErrorCode = 405;
                    json.ErrorMessage = "The method specified in the request is not allowed.";
                    return BadRequest(json);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("GetBook")]
        public IActionResult Getbook()
        {
            try
            {
                List<AddBookModel> BookList = this.addBookManager.Getbook();
                if (BookList != null)
                {
                    return Ok( BookList );
                }
                else
                {
                    var jsonobj = new Jsonmodel();
                    jsonobj.ErrorCode = 405;
                    jsonobj.ErrorMessage = "The method specified in the request is not allowed.";
                    return BadRequest(jsonobj);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("UploadImage")]
        public async Task<IActionResult> Uploadimg(int bookId, string image)
        {
            try
            {
                var imgResult = await this.addBookManager.UploadImg(bookId, image);
                if (imgResult != null)
                {
                    return Ok(new { imgResult });
                }
                else
                {
                    var jsonObj = new Jsonmodel();
                    jsonObj.ErrorCode = 405;
                    jsonObj.ErrorMessage = "The method specified in the request is not allowed.";
                    return BadRequest(jsonObj);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("DeleteBook")]
        public IActionResult Delete(int bookId)
        {
            try
            {
                var delete = this.addBookManager.Delete(bookId);
                if (delete != null)
                {
                    return Ok(new { delete });
                }
                else
                {
                    var json = new Jsonmodel();
                    json.ErrorCode = 405;
                    json.ErrorMessage = "The method specified in the request is not allowed.";
                    return BadRequest(json);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
