using Bytes2you.Validation;
using LibrarySystem.Data.Services.Contracts;
using System;
using WebFormsMvp;

namespace LibrarySystem.Mvp.BookSearcher
{
    public class BookSearcherPresenter : Presenter<IBookSearcherView>
    {
        private readonly IAuthorServices authorService;
        private readonly IBookServices bookService;
        private readonly IGenreServices genreService;
        private readonly IPublisherServices publisherService;

        public BookSearcherPresenter(
            IBookSearcherView view,
            IAuthorServices authorService,
            IBookServices bookService,
            IGenreServices genreService,
            IPublisherServices publisherService) 
            : base(view)
        {
            Guard.WhenArgument(authorService, "Author service is null.").IsNull().Throw();
            Guard.WhenArgument(bookService, "Book service is null.").IsNull().Throw();
            Guard.WhenArgument(genreService, "Genre service is null.").IsNull().Throw();
            Guard.WhenArgument(publisherService, "Publisher service is null.").IsNull().Throw();

            this.authorService = authorService;
            this.bookService = bookService;
            this.genreService = genreService;
            this.publisherService = publisherService;

            this.View.OnAuthorsGetData += View_OnAuthorsGetData;
            this.View.OnGenresGetData += View_OnGenresGetData;
            this.View.OnPublishersGetData += View_OnPublishersGetData;
        }

        private void View_OnAuthorsGetData(object sender, EventArgs e)
        {
            var authors = this.authorService.GetAllAuthors();
            this.View.Model.Authors = authors;
        }

        private void View_OnGenresGetData(object sender, EventArgs e)
        {
            var genres = this.genreService.GetAllGenres();
            this.View.Model.Genres = genres;
        }

        private void View_OnPublishersGetData(object sender, EventArgs e)
        {
            var publishers = this.publisherService.GetAllPublishers();
            this.View.Model.Publishers = publishers;
        }
    }
}
