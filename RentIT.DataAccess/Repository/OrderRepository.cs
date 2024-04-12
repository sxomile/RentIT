﻿using RentIT.DataAccess.Data;
using RentIT.DataAccess.Repository.IRepository;
using RentIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentIT.DataAccess.Repository
{
	public class OrderRepository : Repository<Order>, IOrderRepository
	{
		private readonly ApplicationDbContext _db;
		public OrderRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}
	}
}
