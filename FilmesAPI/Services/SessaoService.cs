using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FluentResults;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Services
{
    public class SessaoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadSessaoDto AdicionaSessao(CreateSessaoDto sessaoDto)
        {
            Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return _mapper.Map<ReadSessaoDto>(sessao);
        }

        public List<ReadSessaoDto> RecuperaSessao()
        {
            List<Sessao> sessao = _context.Sessoes.ToList();
            if (sessao == null) return null;
            return _mapper.Map<List<ReadSessaoDto>>(sessao);
        }

        public ReadSessaoDto RecuperaSessoesPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return sessaoDto;
            }
            return null;
        }

        public Result AtualizaSessao(int id, UpdateSessaoDto sessaoDto)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao == null) return Result.Fail("Sessao não encontrada");
            _mapper.Map(sessao, sessaoDto);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaSessao(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao == null) return Result.Fail("Sessao não encontrada");
            _context.Remove(sessao);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
