using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Services.Implementations
{
    public class MemberService : IMemberService
    {


        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public void addMember(CreateMemberDTO member)
        {
            _memberRepository.AddMember(new Member
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName
            });
        }

        void IMemberService.deleteMember(int memberId)
        {
            throw new NotImplementedException();
        }

        List<MemberDTO> IMemberService.getAllMembers()
        {
            throw new NotImplementedException();
        }

        MemberDTO IMemberService.getMemberById(int Id)
        {
            throw new NotImplementedException();
        }

        void IMemberService.updateMember(UpdateMemberDTO member)
        {
            throw new NotImplementedException();
        }
    }
}
