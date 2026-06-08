# Entity Framework Core – Route .NET Backend Diploma

This folder contains my assignments, exercises, and practice work from the **Entity Framework Core course** in the Route .NET Backend Diploma.

The course focuses on mastering **Entity Framework Core (EF Core)**, understanding its architecture, modeling databases, managing relationships, and building efficient, maintainable, and high-performance data access layers.

---

## Topics Covered

### Session 01 – EF Core Architecture & Setup

* Introduction to ORM

  * What is Object-Relational Mapping (ORM)?
  * Benefits of using an ORM
  * Database-first vs Code-first mindset

* EF Core Approaches

  * Different ways to start an EF Core project
  * Overview of Code First approach

* EF Core Architecture

  * The EF Core pipeline
  * Query processing lifecycle
  * High-level architecture overview

* DbContext & DbSet

  * Purpose of `DbContext`
  * Working with `DbSet<TEntity>`
  * Managing entity collections

* Change Tracker

  * Entity state management
  * How EF Core tracks changes
  * Benefits and common scenarios

* Provider Model

  * SQL Server
  * PostgreSQL
  * SQLite
  * Other supported providers

* Console Application Setup

  * Installing EF Core packages
  * Configuring the connection string
  * DbContext lifetime and configuration

* Configuration by Convention

  * EF Core conventions
  * Default mappings and behaviors
  * Introduction to configuration approaches

* Migrations

  * Migration lifecycle
  * Migration commands
  * Migration history table

* Practice and exercises

  * Hands-on EF Core setup
  * Basic migration exercises

---

### Session 02 – Modeling the Domain

* Configuration Approaches

  * Data Annotations
  * Fluent API

* Key Mapping

  * Primary keys
  * Composite keys
  * GUID keys
  * Alternate keys

* Relationships

  * One-to-One relationships
  * One-to-Many relationships
  * Many-to-Many relationships
  * Cascade delete behavior
  * Self-referencing relationships

* Practice and exercises

  * Domain modeling challenges
  * Relationship mapping exercises

---

### Session 03 – CRUD Operations & Performance

* Shadow Properties & Owned Types

  * Hidden columns and audit fields
  * Value Objects
  * `OwnsOne` and `OwnsMany`

* CRUD Operations

  * LINQ with EF Core
  * Entity States and State Transitions
  * Create, Read, Update, and Delete operations
  * Bulk operations overview

* Tracking & Performance

  * Tracking queries
  * No-Tracking queries
  * Choosing the appropriate approach

* Data Seeding

  * `HasData()`
  * Startup seeding
  * JSON and CSV file seeding

* Loading Related Data

  * Eager Loading
  * Explicit Loading
  * Lazy Loading

* Practice and exercises

  * CRUD implementation tasks
  * Performance and tracking scenarios

---

### Session 04 – Advanced EF Core Features

* Loading Related Data Deep Dive

  * Eager, Explicit, and Lazy Loading review
  * The N+1 Query Problem
  * `AsSplitQuery()`

* Inheritance Mapping Strategies

  * Table Per Hierarchy (TPH)
  * Table Per Type (TPT)
  * Table Per Concrete Type (TPC)
  * Discriminator columns and configuration

* LINQ Joins with EF Core

  * Inner Join
  * Group Join
  * Left Outer Join
  * Cross Join
  * Query syntax vs Method syntax

* Practice and exercises

  * Advanced querying problems
  * Relationship loading scenarios
  * LINQ joins exercises

---

## Skills Practiced

* Understanding ORM concepts and EF Core architecture
* Configuring and setting up EF Core projects
* Working with `DbContext` and `DbSet` effectively
* Managing entity states with the Change Tracker
* Creating and applying database migrations
* Modeling entities and relationships using Data Annotations and Fluent API
* Designing clean and scalable domain models
* Performing CRUD operations with EF Core and LINQ
* Optimizing query performance using Tracking and NoTracking
* Seeding databases with initial data
* Loading related data efficiently and avoiding common pitfalls
* Implementing inheritance mapping strategies
* Writing advanced LINQ queries and joins with EF Core
* Building maintainable and high-performance data access layers
