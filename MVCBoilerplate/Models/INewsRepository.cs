using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBoilerplate.Models
{
    public interface INewsRepository
    {
        List<News> GetNews();
        News GetLatest();
    }
}