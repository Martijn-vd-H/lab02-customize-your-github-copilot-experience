# 📘 Assignment: Secret Santa with Domain-Driven Design

## 🎯 Objective

Design and implement a Secret Santa application in .NET using C# and Domain-Driven Design (DDD) principles. You will model a clear domain, enforce business rules in the domain layer, and coordinate use cases through an application layer.

## 📝 Tasks

### 🛠️ Model the Secret Santa Domain

#### Description
Define the core domain model for Secret Santa using DDD concepts such as entities, value objects, aggregates, and domain services.

#### Requirements
Completed program should:

- Define domain concepts using a clear ubiquitous language (for example: Participant, ExchangeGroup, DrawResult).
- Create at least one entity and one value object that represent core business data.
- Implement aggregate rules that prevent invalid states (for example: no duplicate participants).
- Keep business rules in the domain layer instead of in API or UI code.


### 🛠️ Implement the Application Use Case

#### Description
Implement the Secret Santa draw use case through an application service that uses repository interfaces and returns a valid assignment for all participants.

#### Requirements
Completed program should:

- Create an application service that performs the Secret Santa draw workflow end to end.
- Define repository interfaces in the domain or application boundary, with in-memory implementations for testing.
- Enforce the rule that no participant is assigned to themselves.
- Produce a clear result output (console or API response) that shows each giver and receiver pairing.
