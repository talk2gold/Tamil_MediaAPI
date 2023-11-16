using MediaAPI.Model.Dto;

namespace MediaAPI.Data
{
	public static class MediaStore
	{
	 
        public static List<PocoMediaDTO> mediaList = new List<PocoMediaDTO>()
		{
			  new PocoMediaDTO{Id=1, Title="Sample Image", Description="This is sample image going to be display for practice", Url="https://fujifilm-x.com/wp-content/uploads/2021/01/gfx100s_sample_02_thum-1.jpg"}
			, new PocoMediaDTO{Id=2,Title="Scond Image", Description="cool images going to be dispalyed", Url="https://fujifilm-x.com/wp-content/uploads/2021/01/gfx100s_sample_01_thum.jpg"}
			, new PocoMediaDTO{Id=3,Title="Tamil Imagine", Description="Tamilarasan imagining scenic", Url="https://media.cnn.com/api/v1/images/stellar/prod/220830082740-06-fall-scenic-drives-cascade-lakes-national-byway.jpg?c=original&q=h_618,c_fill"}
		};
		
	}
}
