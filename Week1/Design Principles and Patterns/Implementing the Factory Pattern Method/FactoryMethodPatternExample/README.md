# FactoryMethodPatternExample

This project demonstrates the Factory Method Pattern in a document management system that can create different types of documents (Word, PDF, Excel).

## Structure

- `documents/Document.java`: Interface for documents.
- `documents/WordDocument.java`, `PdfDocument.java`, `ExcelDocument.java`: Concrete document implementations.
- `factory/DocumentFactory.java`: Abstract factory class.
- `factory/WordDocumentFactory.java`, `PdfDocumentFactory.java`, `ExcelDocumentFactory.java`: Concrete factories for each document type.
- `TestFactoryMethodPattern.java`: Test class to demonstrate usage.

## How it works

1. Each document type implements the `Document` interface.
2. Each factory extends `DocumentFactory` and implements the `createDocument()` method to instantiate the correct document type.
3. The test class shows how to use the factories to create and open different document types.

## Usage

Compile and run `TestFactoryMethodPattern.java` to see the output:

```
Opening a Word document.
Opening a PDF document.
Opening an Excel document.
``` 