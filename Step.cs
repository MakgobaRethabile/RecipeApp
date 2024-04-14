class Step
{
    public string Description { get; set; }

    public Step(string description)
    {
        Description = description;
    }

    public override string ToString()
    {
        return Description;
    }
}