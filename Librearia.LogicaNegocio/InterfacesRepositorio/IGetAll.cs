namespace Librearia.LogicaNegocio.InterfacesRepositorio
{
    public interface IGetAll<T>
    {
        IEnumerable<T> GetAll();
    }
}
