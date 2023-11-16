﻿namespace MediaAPI.Model
{
	public class PocoMedia
	{
		public int Id { get; set; }	
		public string Title	{ get; set; }
		public string Description { get; set; }
        public string Url { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
        public bool Active { get; set; }

    }
}
