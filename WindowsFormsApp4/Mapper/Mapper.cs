using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System.IO;

namespace WindowsFormsApp4
{
    public class Mapper
    {
        private static volatile ISqlMapper _mapper = null;



        protected static void Configure(object obj)
        {
            _mapper = null;
        }

        protected static void InitMapper()
        {
            //ConfigureHandler handler = new ConfigureHandler(Configure);
            //DomSqlMapBuilder builder = new DomSqlMapBuilder();
            //_mapper = builder.ConfigureAndWatch(handler);
            try
            {
                ConfigureHandler handler = new ConfigureHandler(Configure);
                DomSqlMapBuilder builder = new DomSqlMapBuilder();
                _mapper = builder.ConfigureAndWatch(handler);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.StackTrace);
                Console.WriteLine(err.Source);
                Console.WriteLine(err.Message);
                Console.WriteLine(err.Data);
            }
        }

        public static ISqlMapper Instance()
        {
            if (_mapper == null)
            {
                try
                {
                    DomSqlMapBuilder dom = new DomSqlMapBuilder();
                    _mapper = dom.Configure("../../SqlMap.config");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something bad happended while building the SqlMapclient instance. : " + e);
                }
            }
            return _mapper;
        }

        public static ISqlMapper Get()
        {
            return Instance();
        }
    }
}
