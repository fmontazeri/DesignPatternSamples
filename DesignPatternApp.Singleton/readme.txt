Introduction
Intent :
Ensure a class has only one instance, and provide a global point of access to it.
Encapsulated "just-in-time initialization" or "initialization on first use".

Problem :
Application needs one, and only one, instance of an object. Additionally, lazy initialization and global access are necessary.

The singleton pattern is one of the best-known patterns in software engineering. Essentially, a singleton is a class which only allows a single instance of itself to be created, and usually gives simple access to that instance. Most commonly, singletons don't allow any parameters to be specified when creating the instance - as otherwise a second request for an instance but with a different parameter could be problematic! (If the same instance should be accessed for all requests with the same parameter, the factory pattern is more appropriate.) This article deals only with the situation where no parameters are required. Typically a requirement of singletons is that they are created lazily - i.e. that the instance isn't created until it is first needed.

There are various different ways of implementing the singleton pattern in C#. I shall present them here in reverse order of elegance, starting with the most commonly seen, which is not thread-safe, and working up to a fully lazily-loaded, thread-safe, simple and highly performant version.

All these implementations share four common characteristics, however:

*A single constructor, which is private and parameterless. This prevents other classes from instantiating it (which would be a violation of the pattern). Note that it also prevents subclassing - if a singleton can be subclassed once, it can be subclassed twice, and if each of those subclasses can create an instance, the pattern is violated. The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
*The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
*A static variable which holds a reference to the single created instance, if any.
*A public static means of getting the reference to the single created instance, creating one if necessary.

Note that all of these implementations also use a public static property Instance as the means of accessing the instance. In all cases, the property could easily be converted to a method, with no impact on thread-safety or performance.
https://csharpindepth.com/articles/singleton




The static constructor for a class executes at most once in a given application domain.
The execution of a static constructor is triggered by the first of the following events to occur within an application domain:

*An instance of the class is created.
*Any of the static members of the class are referenced.

The CLI specification (ECMA 335) states in section 8.9.5:

*A type may have a type-initializer method, or not.
*A type may be specified as having a relaxed semantic for its type-initializer method (for convenience below, we call this relaxed semantic BeforeFieldInit)
*If marked BeforeFieldInit then the type's initializer method is executed at, or sometime before, first access to any static field defined for that type
*If not marked BeforeFieldInit then that type's initializer method is executed at (i.e., is triggered by):
    first access to any static or instance field of that type, or
    first invocation of any static, instance or virtual method of that type
https://csharpindepth.com/Articles/BeforeFieldInit