// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.Immutable;
using Bicep.Core.Parsing;
using Bicep.Core.Syntax;

namespace Bicep.Core.Intermediate;

public static class ExpressionFactory
{
    public static ObjectPropertyExpression CreateObjectProperty(string name, Expression value, SyntaxBase? sourceSyntax = null)
        => new(
            sourceSyntax,
            new StringLiteralExpression(sourceSyntax, name),
            value);

    public static ObjectExpression CreateObject(IEnumerable<ObjectPropertyExpression> properties, SyntaxBase? sourceSyntax = null)
        => new(sourceSyntax, properties.ToImmutableArray());

    public static ArrayExpression CreateArray(IEnumerable<Expression> items, SyntaxBase? sourceSyntax = null)
        => new(sourceSyntax, items.ToImmutableArray());

    public static StringLiteralExpression CreateStringLiteral(string value, SyntaxBase? sourceSyntax = null)
        => new(sourceSyntax, value);

    public static BooleanLiteralExpression CreateBooleanLiteral(bool value, SyntaxBase? sourceSyntax = null)
        => new(sourceSyntax, value);
}
