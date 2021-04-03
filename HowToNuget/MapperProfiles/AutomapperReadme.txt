AutoMapper uses the following conventions:

It will automatically map properties with the same names.
If the source object has some association with other objects, then it will try to map with properties on the destination object whose name is a combination of the source class name and property name in the Pascal case. 
It will try to map methods on source object which has a Get prefix with a property on destination object with the name excluding the Get prefix.