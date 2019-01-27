# Head First Design Pattern (unofficial) for .Net Core

## Introduction

This is C# code done with .Net Core 2, VS Code 1.3 and Visual Studio 2017.

## How to use

It can be run with Visual Studio or VS Code (and CLI of course)

<!--TODO:Add gif VS and VS Code How to run -->

### Some additional information

"\#define vscode" directives were added in task.json ("dotnet build \<\<sln name>> /p:DefineConstants=vscode") and in every Program.cs were added "\#if (!vscode)".

It were added for run from VS in order to console window will keep open

## 1. Strategy

SimpleQuack is like Quack class in the book. This name was changed because msbuild compiler said "'Quack': member names cannot be the same as their enclosing type [Strategy]"

## 2. Observer

### Observer

### Built-in Observer

### Observer using Events