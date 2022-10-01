﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ApiModels.InstructorItemDTO
{
    public class UpdateProfileResponse
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string Professional { get; set; }
        public string Introduction { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedLink { get; set; }
        public string YoutubeLink { get; set; }
        public string TwitterLink { get; set; }
        public string ProfileLink { get; set; }
    }
}
