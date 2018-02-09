using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mdryden.AutoMapper.GenericInjection
{
	public class Mapper<TOne, TTwo> : IMapper<TOne, TTwo>
	{
		IMapper mapper;

		public Mapper(IMapper mapper)
		{
			this.mapper = mapper;
		}

		public TOne Map(TTwo input)
		{
			return mapper.Map<TOne>(input);
		}

		public TOne[] Map(IEnumerable<TTwo> input)
		{
			return mapper.Map<TOne[]>(input);
		}

		public TTwo Map(TOne input)
		{
			return mapper.Map<TTwo>(input);
		}
		public TTwo[] Map(IEnumerable<TOne> input)
		{
			return mapper.Map<TTwo[]>(input);
		}
	}
}
