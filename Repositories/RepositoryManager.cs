using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager
    {
        private Lazy<CategoryRepository> _categoryRepository { get; set; }

        public RepositoryManager() {
            _categoryRepository = new Lazy<CategoryRepository>(() => new CategoryRepository());
        }

        public CategoryRepository CategoryRepository => _categoryRepository.Value;
    }
}
