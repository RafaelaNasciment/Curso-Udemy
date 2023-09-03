using curso_csharp_udemy.Services;

bool worker = false;

if (worker)
{
    WorkerService workerService = new WorkerService();
    workerService.Handle();
}

PostService postService = new PostService();    
postService.Handle();