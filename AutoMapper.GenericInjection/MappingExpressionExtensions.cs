using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mdryden.AutoMapper.GenericInjection
{
    public static class MappingExpressionExtensions
	{
		public static void InjectGeneric<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression, IServiceCollection services)
		{
			services.AddTransient<IMapper<TSource, TDestination>, Mapper<TSource, TDestination>>();
			services.AddTransient<IMapper<TDestination, TSource>, Mapper<TDestination, TSource>>();
		}
	}
}
