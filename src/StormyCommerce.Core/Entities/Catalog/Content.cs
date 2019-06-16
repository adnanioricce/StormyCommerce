﻿using StormyCommerce.Core.Entities.Customer;
using System;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog
{
	public abstract class Content : BaseEntity 
	{
		private bool isDeleted;

	        protected Content()
        	{
	            CreatedOn = DateTimeOffset.Now;
        	    LatestUpdatedOn = DateTimeOffset.Now;
	        }

        	[Required(ErrorMessage = "The {0} field is required.")]
	        [StringLength(450)]
        	public string Name { get; set; }

	        [Required(ErrorMessage = "The {0} field is required.")]
        	[StringLength(450)]
	        public string Slug { get; set; }

        	[StringLength(450)]
	        public string MetaTitle { get; set; }

        	[StringLength(450)]
	        public string MetaKeywords { get; set; }

        	public string MetaDescription { get; set; }

	        public bool IsPublished { get; set; }

        	public DateTimeOffset? PublishedOn { get; set; }

	        public bool IsDeleted
        	{
	            get
        	    {
                	return isDeleted;
	            }

        	    set
	            {
        	        isDeleted = value;
                	if (value)
	                {
        	            IsPublished = false;
                	}
	            }
        	}

	        public long CreatedById { get; set; }

        	public StormyCustomer CreatedBy { get; set; }

	        public DateTimeOffset CreatedOn { get; set; }

        	public DateTimeOffset LatestUpdatedOn { get; set; }

	        public long LatestUpdatedById { get; set; }

        	public StormyCustomer LatestUpdatedBy { get; set; }

	}
}
