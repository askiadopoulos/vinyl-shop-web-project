using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.ViewModels
{
    public class VinylFormViewModel
    {
        // Properties
        //public int? Id { get; set; }
        public Vinyl Vinyl { get; set; }

        // Property Id from Category
        [Display(Name = "Product Category")]
        //public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        // Property Id from Genre
        [Display(Name = "Music Genre")]
        //public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        // Property Id from RecordLabel
        [Display(Name = "Record Label")]
        //public short RecordLabel { get; set; }
        public IEnumerable<RecordLabel> RecordLabels { get; set; }

        // TODO: Find what is unnecessary
        //public short ContentFileId { get; set; }
        //public ContentFile ContentFile { get; set; }
        public IEnumerable<ContentFile> ContentFiles { get; set; }



        [Display(Name = "Thumbnail")]
        public FileType ImageSample
        {
            get { return FileType.ImageSample; }
        }

        [Display(Name = "Audio Sample")]
        public FileType AudioSample
        {
            get { return FileType.AudioSample; }
        }

    }
}