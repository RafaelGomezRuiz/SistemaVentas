using AutoMapper;
using SistemaVentas.Core.Application.Dtos.Account;
using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Application.ViewModels.Direcciones;
using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Application.ViewModels.Marca;
using SistemaVentas.Core.Application.ViewModels.Products;
using SistemaVentas.Core.Application.ViewModels.Users;
using SistemaVentas.Core.Domain.Entities;
using StockApp.Core.Application.ViewModels.Categories;
using StockApp.Core.Application.ViewModels.Products;
namespace StockApp.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Productos
            CreateMap<ProductoEntity, ProductoViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore());

            CreateMap<ProductoEntity, SaveProductoViewModel>()
                .ForMember(destino => destino.ImagenesRuta, otp => otp.Ignore())
                .ForMember(destino => destino.Images, otp => otp.Ignore())
                .ForMember(destino => destino.Categorias, otp => otp.Ignore())
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
                .ForMember(destino => destino.Marca, otp => otp.Ignore())
                .ForMember(destino => destino.Categorias, otp => otp.Ignore())
                .ForMember(destino => destino.Inventario, otp => otp.Ignore())
                .ForMember(destino => destino.Imagenes, otp => otp.Ignore());
            #endregion

            #region categoria
            CreateMap<CategoriaEntity, CategoriaViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore());

            CreateMap<CategoriaEntity, SaveCategoriaViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
                .ForMember(destino => destino.Productos, otp => otp.Ignore());
            #endregion

            #region marca
            CreateMap<MarcaEntity, MarcaEntity>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore());

            CreateMap<MarcaEntity, SaveMarcaViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
                .ForMember(destino => destino.Productos, otp => otp.Ignore());
            #region marca
            CreateMap<MarcaEntity, MarcaEntity>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore());

            CreateMap<MarcaEntity, SaveMarcaViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
                .ForMember(destino => destino.Productos, otp => otp.Ignore());
            #endregion
            #endregion

            #region Inventario
            CreateMap<InventarioEntity, InventarioViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore());

            CreateMap<InventarioEntity, SaveInventarioViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Created, otp => otp.Ignore())
                .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
                .ForMember(destino => destino.LastModified, otp => otp.Ignore())
                .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
                .ForMember(destino => destino.Productos, otp => otp.Ignore())
                .ForMember(destino => destino.Carrito, otp => otp.Ignore());
            #endregion

            #region Direccion
            CreateMap<DireccionEntity, DireccionViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.UserId, otp => otp.Ignore());


            CreateMap<DireccionEntity, SaveDireccionViewModel>()
                .ReverseMap();
            #endregion

            #region CarritoCompras
            CreateMap<CarritoCompraEntity, CarritoCompraViewModel>()
                .ReverseMap();


            CreateMap<CarritoCompraEntity, SaveCarritoCompraViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Venta, otp => otp.Ignore())
                .ForMember(destino => destino.InventarioProductos, otp => otp.Ignore());

            #endregion

            #region Ventas
            CreateMap<DireccionEntity, DireccionViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.UserId, otp => otp.Ignore());


            CreateMap<DireccionEntity, SaveDireccionViewModel>()
                .ReverseMap();
            #endregion


            CreateMap<AuthenticationRequest, LoginViewModel>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, SaveUserViewModel>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ReverseMap();

            CreateMap<ForgotPasswordRequest, ForgotPasswordViewModel>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordViewModel>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ReverseMap();

            #region CQRS

            //    #region Product
            //CreateMap<CreateProductCommand, Product>()
            //    .ForMember(destino => destino.Category, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();

            //CreateMap<UpdateProductCommand, Product>()
            //    .ForMember(destino => destino.Category, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();

            //CreateMap<ProductUpdateResponse, Product>()
            //    .ForMember(destino => destino.Category, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();
            //#endregion

            //    #region Category
            //CreateMap<CreateCategoryCommand, Category>()
            //    .ForMember(destino => destino.Products, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();

            //CreateMap<UpdateCategoryCommand, Category>()
            //    .ForMember(destino => destino.Products, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();

            //CreateMap<UpdateCategoryResponse, Category>()
            //    .ForMember(destino => destino.Products, otp => otp.Ignore())
            //    .ForMember(destino => destino.Created, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModified, otp => otp.Ignore())
            //    .ForMember(destino => destino.LastModifiedBy, otp => otp.Ignore())
            //    .ForMember(destino => destino.CreatedBy, otp => otp.Ignore())
            //    .ReverseMap();
            //#endregion


            #endregion
        }
    }
}
