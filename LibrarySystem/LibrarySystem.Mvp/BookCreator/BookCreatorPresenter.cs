using System;
using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using WebFormsMvp;
using Bytes2you.Validation;

namespace LibrarySystem.Mvp.BookCreator
{
    public class BookCreatorPresenter : Presenter<IBookCreatorView>
    {
        private readonly IAuthorServices authorService;
        private readonly IBookServices bookService;
        private readonly IGenreServices genreService;
        private readonly IPublisherServices publisherService;

        public BookCreatorPresenter(
            IBookCreatorView view,
            IAuthorServices authorService,
            IBookServices bookService,
            IGenreServices genreService,
            IPublisherServices publisherService) 
            : base(view)
        {
            Guard.WhenArgument(view, "View is null.").IsNull().Throw();
            Guard.WhenArgument(authorService, "Author service is null.").IsNull().Throw();
            Guard.WhenArgument(bookService, "Book service is null.").IsNull().Throw();
            Guard.WhenArgument(genreService, "Genre service is null.").IsNull().Throw();
            Guard.WhenArgument(publisherService, "Publisher service is null.").IsNull().Throw();

            this.authorService = authorService;
            this.bookService = bookService;
            this.genreService = genreService;
            this.publisherService = publisherService;
        }
        
        public void View_OnCreateBook(object sender, CreateBookEventArgs e)
        {
            var pictureCollection = new List<Picture>();
            foreach (var picturePath in e.PictureFilePaths)
            {
                pictureCollection.Add(new Picture() { Name = picturePath });
            }

            var book = new Book()
            {
                Title = e.Title,
                UserId = e.UserId,
                AuthorId = e.AuthorId,
                PublisherId = e.PublisherId,
                GenreId = e.GenreId,
                Description = e.Description,
                Price = e.Price,
                Language = e.Language,
                IssueDate = e.IssueDate,
                PagesCount = e.PagesCount,
                Pictures = pictureCollection
            };

            this.bookService.AddBook(book);
        }

        public void View_OnAuthorssGetData(object sender, EventArgs e)
        {
            this.View.Model.Authors = this.authorService.GetAllAuthors();
        }

        public void View_OnPublishersGetData(object sender, EventArgs e)
        {
            this.View.Model.Publishers = this.publisherService.GetAllPublishers();
        }
        
        public void View_OnGenresrsGetData(object sender, EventArgs e)
        {
            this.View.Model.Genres = this.genreService.GetAllGenres();
        }
    }
}
