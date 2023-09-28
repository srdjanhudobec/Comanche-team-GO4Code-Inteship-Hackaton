using AutoMapper;
using ComancheSocialNetwork.DTOs.Attachment;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Profiles
{
    public class AttachmentProfile:Profile
    {
        public AttachmentProfile()
        {
            CreateMap<AttachmentModel, AttachmentModelPostRequest>();
            CreateMap<AttachmentModelPostRequest, AttachmentModel>();
            CreateMap<AttachmentModel, AttachmentModelPostResponse>();
            CreateMap<AttachmentModelPostResponse, AttachmentModel>();
            CreateMap<AttachmentModel, AttachmentModelGetResponse>();
            CreateMap<AttachmentModelGetResponse, AttachmentModel>();
            CreateMap<AttachmentModelGetResponse, AttachmentModelPostGet>();
            CreateMap<AttachmentModelPostGet, AttachmentModelGetResponse>();
        }
    }
}
