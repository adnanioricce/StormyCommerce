# What is a Command ?
A Command Class, represents one objective or Will(what seem better to you) to Write in the entity Model(ie,Create,Update and Delete), and following the Single Responsability Principle, has to be just one objective, and obviously, has to be just one Command(don't make two versions of the same Command). Usually, you should use this approach to implement Business logic(ex: Create,Update,Delete a entity). 
# What is a Query ? 
with the same objective above, the Query should be used to perform read operations.
# Who is the Handler ?
Handler, like the name spoil, it's who actually handle the input. The handler process the Command and follow the flow. In this way, the handler and mediator almost replace the controller logic.
# Who is the mediator 
Mediator is the the "messenger" in the middle of the parts. The Mediator takes the requests(aka messages), and pass them to the correct classes. This funcionality is a bit like the DI injector works, he stores the types, and searchs for the correct handler for the message.
# Bus?? 

# Commit 
Follow the name, the above finish the process
# Notification 

# Publish

# The Stacks 
The command and query usually has some components that is called "stack". In the case of the Query, a example of a stack would work in the following way 
->Receives the input from the UI 
->Query performs the Read operations on the database provider(or the messaging service) cache. 
the command can be a little different 
->Receives the input from the UI
->Input is mapped to a command 
->Command performs the Write operations on the Data Model. 
has a variety of ways to implement all this, for now, follow the images. 


## Command Stack 

# The flow 
At least in this project, when handling Requests from the controller, the commands should: 
->Mapping(if necessary): the external object should use the internal data model
->Validation(if necessary): Even with the mapping, the model still can be invalid, so Write validations for the model(ie:"RuleFor(customer => customer.Age => 18;");
->Handle : Perform the needed processing for the business logic, usually, you would try to process the needed logic to handle the entities(ie: Create Product,Update Product Categories and so on). In this way, you would make a handle for each situation. In the code, Handle is a simple method.
->Notification: Notify errors finded in the processing of the command 
->Event: Simple classes, are used to "warn" the everybody that something happens. Can be stored in Memory or in a proper Persistence solution(ie: Redis,RabbitMq,MongoDb and so on). But why? Imagine one SignUp Request, you handle it, and now you throw a event to the bus/mediator, this way, the SendEmailCommand can be called to send the confirmation email to the user. 



# Tips
Try to put all business logic on the Commands, avoid bloathing the controllers, leave the controllers to "control" the flow
