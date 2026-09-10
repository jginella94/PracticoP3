
namespace Librearia.LogicaNegocio.InterfacesRepositorio
{
    public interface IUpdate<T>
    {
        void Update(int id, T obj);
    }
}
