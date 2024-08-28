using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using server.DTO;
using server.Services.BookService;

namespace server.Controllers
{
	[Route("[controller]")]
    [ApiController]
	public class BookController : ControllerBase
	{
		private readonly IBookService _bookService;

		public BookController(IBookService bookService){
			_bookService = bookService;
		}

		[HttpPost("AddBook")]
		public async Task<IActionResult> AddBook([FromBody] BookDTO bookDTO){
			try
			{
			var result = await _bookService.AddBook(bookDTO);
			return Ok(result);
			}
			catch(Exception ex)
			{
				return Unauthorized(new { Message = ex.Message});
			}
		}

		[HttpGet("GetBooks")]
		public async Task<IActionResult> GetBooks(){
			try
			{
				var result = await _bookService.GetBooks();
				return Ok(result);
			}
			catch(Exception ex)
			{
				return Ok(new {Message = ex.Message});
			}
		}

		[HttpGet("GetCategories")]
		public async Task<IActionResult> GetCategories(){
			try
			{
				var result = await _bookService.GetCategories();
				return Ok(result);
			}
			catch(Exception ex)
			{
				return Unauthorized(new {Message = ex.Message});
			}
		}

		[HttpGet("GetBooksByCategory")]
		public async Task<IActionResult> GetBookByCategory(string Category){
			try
			{
				var result = await _bookService.GetBookByCategory(Category);
				return Ok(result);
			}
			catch(Exception ex)
			{
				return Unauthorized(new {Message = ex.Message});
			}
		}
	
		[HttpDelete("DeleteBooks")]
		public async Task<IActionResult> DeleteBook (BookDTO bookDTO){
			try
			{
				var result = await _bookService.DeleteBook(bookDTO);
				if(result)
				{
					return Ok(new {Message = "Book Deleted Succesfully"});
				}else
				{
					return NotFound(new {Message = "Book Not Found"});

				}
			}
			catch(Exception ex)
			{
				return Unauthorized(new {Message = ex.Message});
			}
		}

	}
}