using FitZone.Domain.Models.DTOs.MembersDTOs;
using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using CreateMemberDTO = FitZone.Domain.Models.DTOs.MembersDTOs.CreateMemberDTO;


namespace FitZone.Application.Services.Interfaces
{
    public interface IMemberService
    {
        List<MemberDTO> getAllMembers();

        MemberDTO getMemberById(int Id);    
        void addMember(CreateMemberDTO member);

        void updateMember(UpdateMemberDTO member);

        void deleteMember(int memberId);
    }
}
