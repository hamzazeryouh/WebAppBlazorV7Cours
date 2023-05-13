using Domain.Entites;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

public class DataContext: IdentityDbContext<Users>
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{ }
}
