using App_Gallery.Views.Layouts;
using App_Gallery.Models;
using App_Gallery.Views.Components.Mains;

namespace App_Gallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description = "Organização seguencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "Absolute layout",
                        Description = "Liberdade Total para posicionar e dimensionar os elementos na tela.",
                        Page= typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "Flex layout",
                        Description = "Organiza os elementos de forma seguencial e possui muita personalização.",
                        Page= typeof(FlexLayoutPage)
                    }
                }
            });

            categories.Add(new Category()
            {
                Name = "Components (Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Um componente que cria uma caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela.",
                        Page = typeof(LabelPage)
                    },
                }
            });

            return categories;
        }
    }
}
