1) Types of Routing:-

There are 2 types of Routing in MVC application
Conventional or Traditional Routing (Using Routing Config)
Attribute Routing (Available in MVC 5) 

Conventional or Traditional Routing :-

Conventional Routing: Routing where an action determines to invoke through in routing table defined in WebAPIConfig.cs file,called as convection Based Routin
RouteConfig file is available in the App_Start folder.
We need to register all the routes to make them operational.


Conventional Routing:-

public class RouteConfig  
    {  
        public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
  
            routes.MapRoute(  
                name: "Default",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
            );  
        }  
    }  
Attribute Routing :-

We need Attribute Based Routing Over Convention-based routing,it is hard support certain URL Patterns that are common in Restful WEb APIs.
All the concepts are just like the conventional approach but here, we define all the routes and attributes. 

In attribute, we define the routing on a simple controller or action method. 

public class RouteConfig  
    {  
        public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
  			routs.mapMvcAttributeRoutes();
            routes.MapRoute(  
                name: "Default",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
            );  
        }  
    } 



2) Action Filters :-
 
Action Filter is an attribute that you can apply to a controller action or an entire controller. 
This filter will be called before and after the action starts executing and after the action has executed.
 Action filters implement the IActionFilter interface that has two methods OnActionExecuting andOnActionExecuted. 
OnActionExecuting runs before the Action and gives an opportunity to cancel the Action call. 
These filters contain logic that is executed before and after a controller action executes, you can use an action filter, for instance, to modify the view data that a controller action returns.

namespace ActionFiltersinMVC.AuthData    
{    
    public class AuthAttribute: ActionFilterAttribute,    
    IAuthenticationFilter    
    {    
    
        public void OnAuthentication(AuthenticationContextfilterContext)    
        {    
            //Logic for authenticating a user    
        }    
    
        //Runs after the OnAuthentication method    
        public void OnAuthenticationChallenge(AuthenticationChallengeContextfilterContext)    
        {    
            //TODO: Additional tasks on the request    
        }    
    }    
} 

 3) AREA in MVC : Areas are logical grouping of Controller, Models and Views and other related folders for a module in MVC applications.
 By convention, a top Areas folder can contain multiple areas. Using areas, we can write more maintainable code for an application cleanly separated according 
 to the modules.
 
4) HTTP  GET:  Get method is used to retrieve or get the information from the given server using a given URL
         POST:  Post is used for sending data to the server such as uploading a file or transferring some data or adding a new
               row to the back end table to any kind of web form 
         PUT: The PUT method is most often used to update an existing resource.
         PATCH: The PATCH method is used to update the values of the resource properties.
         DELETE: The PATCH method is used to update the values of the resource properties.
 5)Collection : Collections standardize the way of which the objects are handled by your program. In other words, 
               it contains a set of classes to contain elements in a generalized manner. With the help of collections,
               the user can perform several operations on objects like the store, update, delete, retrieve, search, sort etc.
