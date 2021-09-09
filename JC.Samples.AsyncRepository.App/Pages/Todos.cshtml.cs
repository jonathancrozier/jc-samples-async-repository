using JC.Samples.AsyncRepository.Entities;
using JC.Samples.AsyncRepository.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JC.Samples.AsyncRepository.App.Pages
{
    /// <summary>
    /// Todos Index Model.
    /// </summary>
    public class TodosModel : PageModel
    {
        #region Properties

        public IEnumerable<Todo> Todos { get; private set; }

        #endregion

        #region Readonlys

        private readonly ILogger<TodosModel> _logger;
        private readonly IUnitOfWork         _unitOfWork;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="logger">The logger instance to use</param>
        /// <param name="unitOfWork">The Unit of Work Interface</param>
        public TodosModel(ILogger<TodosModel> logger, IUnitOfWork unitOfWork)
        {
            _logger     = logger;
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the overall page.
        /// </summary>
        /// <returns><see cref="Task"/></returns>
        public async Task OnGet()
        {
            _logger.LogDebug("Getting Todo items...");

            Todos = await _unitOfWork.TodoRepository.GetTopXIncompleteTodosAsync(10);
        }

        #endregion
    }
}