using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.Entities;
using FitZone.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly FitZoneDbContext _context;

        public MemberRepository(FitZoneDbContext context)
        {
            _context = context;
        }


        public void AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }


        public void UpdateMember(Member member)
        {
            var memberOld = _context.Members.Find(member.Id);
            memberOld.FirstName = member.FirstName;
            memberOld.LastName = member.LastName;
            _context.SaveChanges();
        }



       public void DeleteMember(Member member)
        {
            _context.Members.Remove(member);
            _context.SaveChanges();
        }


        public Member GetMemberById(int id)
        {
            return _context.Members.Find(id);
        }


        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }





    }
}
