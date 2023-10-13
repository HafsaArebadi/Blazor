namespace BlazorApp1
{
    public class MovieSearchResponse
    {
       
            public string? Response { get; set; }
            public int TotalResults { get; set; }
            public List<Movie>? Search { get; set; }
        

        public class Movie
        {
            public string? Title { get; set; }
            public string? Year { get; set; }
            public string? Poster { get; set; }
        }
    }
}
