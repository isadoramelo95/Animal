using Domain;
using Repository.Interfaces;
using Service.Interface;

namespace Service
{
    public class AnimalService : IAnimalService<Animal>
    {
        IAnimalRepository<Animal> _repository;
        public AnimalService(IAnimalRepository<Animal> repository) =>
            _repository = repository;
        public Animal Obter(Animal entity) => _repository.Obter(entity);

        public List<Animal> ObterTodos(int id) => _repository.ObterTodos();

        public void Inserir(Animal animal) => _repository.Inserir(animal);

        public void Atualizar(Animal animal)
        => _repository.Atualizar(animal);

        public void Remover(Animal animal)
        => _repository.Excluir(animal);
    }
}