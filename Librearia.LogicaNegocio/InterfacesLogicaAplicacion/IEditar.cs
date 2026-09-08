
namespace Librearia.LogicaNegocio.InterfacesLogicaAplicacion
{
    public interface IEditar<T>
    {
        void Ejecutar(int id, T obj);
    }
}
