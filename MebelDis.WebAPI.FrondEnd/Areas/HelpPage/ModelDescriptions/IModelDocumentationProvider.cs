using System;
using System.Reflection;

namespace MebelDis.WebAPI.FrondEnd.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}