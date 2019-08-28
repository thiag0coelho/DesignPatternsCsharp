# Chain of Responsability

* Pass requests through a chain of handlers. Each handler decides to process the request, continue to the next handler or stop the chain. 
* Can be used with IDisposable to rollback all the processing that was made