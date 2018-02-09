using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mdryden.AutoMapper.GenericInjection
{
	public interface IMapper<TOne, TTwo> 
	{
		TOne Map(TTwo input);
		TOne[] Map(IEnumerable<TTwo> input);
		TTwo Map(TOne input);
		TTwo[] Map(IEnumerable<TOne> input);
	}
}
