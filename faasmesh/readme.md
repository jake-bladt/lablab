# FaaS Mesh (Smesh)

## Overview

The core premise of FaaS Mesh is to create a distributed system like Apache Storm or Microsoft Orleans where the primary distribution and
coordination model is functions as a service. The creation of external services would be handled by convention over configuration over code.
The coordination would be the responsibility of the Smesh library. Invocation would look like this:

```csharp

var customer = await smeshFactory.GetObjectAsync<ICustomer>(new ArgBall { FirstName: "Jake", LastName: "Bladt" });
customer.AddLoyaltyCard(loyaltyCard);

```

Smesh would support the actor model of coding (a la Akka.)
