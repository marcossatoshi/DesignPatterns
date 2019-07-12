namespace DesignPatterns
{
    public class Builder
    {
        private string complexProperty;
        private string complexProperty2;
        private string complexProperty3;
        public string ComplexProperty
        {
            get { return complexProperty; }
        }

        public string ComplexProperty2
        {
            get { return complexProperty2; }
        }

        public string ComplexProperty3
        {
            get { return complexProperty3; }
        }

        public Builder setComplexProperty(string p1) { this.complexProperty = p1; return this; }
        public Builder setComplexProperty2(string p2) { this.complexProperty2 = p2; return this; }
        public Builder setComplexProperty3(string p3) { this.complexProperty3 = p3; return this; }
        public BuilderObject Build()
        {
            return new BuilderObject(this);
        }
    }

    public class BuilderObject
    {
        public string ComplexProperty { get; set; }
        public string ComplexProperty2 { get; set; }
        public string ComplexProperty3 { get; set; }

        public BuilderObject(Builder builder)
        {
            this.ComplexProperty = builder.ComplexProperty;
            this.ComplexProperty2 = builder.ComplexProperty2;
            this.ComplexProperty3 = builder.ComplexProperty3;
        }

        public override string ToString()
        {
            return ComplexProperty + " - " + ComplexProperty2 + " - " + ComplexProperty3;
        }
    }
}
