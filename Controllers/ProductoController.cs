using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Models;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {


        [HttpGet("{idUsuario}")]
        public List<Producto> GetSaleProduct( long idUsuario)
        {
            // ManejadorProducto.ObtenerProductoVendido(idUsuario);
            return ManejadorProducto.ObtenerProductos(idUsuario);
        }


        [HttpPost]
        public void InsertProduct(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
        }

        [HttpPut]
        public void UpDateProduct(Producto producto)
        {

            ManejadorProducto.ModificarProducto(producto);
        }

        [HttpDelete("{idProducto}")]
        public void DeleteProduct(int idProducto)
        {
            ManejadorProducto.EliminarProducto(idProducto);
        }


    }
}
