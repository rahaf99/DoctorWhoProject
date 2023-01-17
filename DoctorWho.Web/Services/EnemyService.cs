using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using DoctorWho.Web.Validators;

namespace DoctorWho.Web.Services
{
    public class EnemyService : IEnemyService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IEnemyRepository _enemyRepository;
        private readonly IMapper _mapper;
        public EnemyService(DoctorWhoCoreDbContext context, IEnemyRepository enemyRepository, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _enemyRepository = enemyRepository;
            _mapper = mapper;
        }
        public IEnumerable<EnemyDto> GetAllEnemies()
        {
            var Enemies = _enemyRepository.GetAllEnemies();
            var response = Enemies.Select(x => _mapper.Map<EnemyDto>(x));
            return response;
        }
        public void CreateEnemy(EnemyDto enemyDto)
        {
            var enemy = _mapper.Map<Enemy>(enemyDto);
            _enemyRepository.CreateEnemy(enemy);
        }

        public void DeleteEnemy(int EnemyId)
        {
            throw new NotImplementedException();
        }

        public void GetEnemyById(int EnemyId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEnemy(EnemyDto enemyDto)
        {
            throw new NotImplementedException();
        }
    }
}
