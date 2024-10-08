using System;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers;

public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
{
    private readonly IConfiguration __config;
    public ProductUrlResolver(IConfiguration _config)
    {
            __config = _config;
    }

    public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
    {
        if(!string.IsNullOrEmpty(source.PictureUrl)){
            return __config["ApiUrl"] + source.PictureUrl;
        }
        return null;
    }
}
