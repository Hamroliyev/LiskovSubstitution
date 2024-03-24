# **L**iskovSubstitution

When extending a class, remember that you should be
able to pass objects of the subclass in place of objects of
the parent class without breaking the client code.

This means that the subclass should remain compatible with
the behavior of the superclass. When overriding a method,
extend the base behavior rather than replacing it with something else entirely
