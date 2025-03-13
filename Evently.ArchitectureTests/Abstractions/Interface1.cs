using FluentAssertions;
using NetArchTest.Rules;

namespace Evently.ArchitectureTests.Abstractions;

internal static class TestResultExtensions
{
    internal static void ShouldBeSuccesful(this TestResult testResult)
    {
        testResult.FailingTypes?.Should().BeEmpty();
    }
}
