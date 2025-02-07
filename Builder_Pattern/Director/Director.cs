﻿using Builder_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Director
{
    public class Director
    {
		private IBuilder _builder;
		public IBuilder Builder
		{	
			set { _builder = value; }
		}


        public void BuildMinimalViableProduct()
		{
			_builder.BuildPartA();
		}

		public void BuildFullFeaturedProduct()
		{
            _builder.BuildPartA();
            _builder.BuildPartB();	
            _builder.BuildPartC();
        }
    }
}
