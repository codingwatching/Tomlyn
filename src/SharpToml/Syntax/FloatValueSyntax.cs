// Copyright (c) 2019 - Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
namespace SharpToml.Syntax
{
    public sealed class FloatValueSyntax : ValueSyntax
    {
        private SyntaxToken _token;

        public FloatValueSyntax() : base(SyntaxKind.Float)
        {
        }

        public SyntaxToken Token
        {
            get => _token;
            set => ParentToThis(ref _token, value, value != null && value.TokenKind.IsFloat(), TokenKind.Float);
        }

        public double Value { get; set; }

        public override void Accept(SyntaxVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override int ChildrenCount => 1;

        protected override SyntaxNode GetChildrenImpl(int index)
        {
            return Token;
        }
    }
}