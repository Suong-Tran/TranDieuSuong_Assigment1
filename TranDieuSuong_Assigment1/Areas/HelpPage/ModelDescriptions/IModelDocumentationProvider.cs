using System;
using System.Reflection;

namespace TranDieuSuong_Assigment1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}