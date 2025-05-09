using App_Gallery.Views.Layouts;
using App_Gallery.Models;
using App_Gallery.Views.Components.Mains;
using App_Gallery.Views.Components.Visuals;
using App_Gallery.Views.Components.Forms;

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
                    },
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
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela.",
                        Page = typeof(LabelPage)
                    },
                    new Component
                    {
                        Title = "Buttons",
                        Description = "Apresenta um botão na tela.",
                        Page = typeof(ButtonPage)
                    },
                    new Component
                    {
                        Title = "Images",
                        Description = "Apresenta uma imagem na tela.",
                        Page = typeof(ImagePage)
                    },
                    new Component
                    {
                        Title = "Images Button",
                        Description = "Apresenta uma imagem com comportamento de botão.",
                        Page = typeof(ImageButtonPage)
                    },
                }
            });

            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component> {
                    new Component {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },
                     new Component {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    },
                     new Component {
                        Title = "Shadow",
                        Description = "Cria sombras em nossos elementos.",
                        Page = typeof(ShadowPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Formulários",
                Components = new List<Component> {
                    new Component {
                        Title = "Entry",
                        Description = "Cria uma caixa de entrada de textos.",
                        Page = typeof(EntryPage)
                    },
                    new Component {
                        Title = "Editor",
                        Description = "Cria uma caixa de entrada de textos de múltiplas linhas.",
                        Page = typeof(EditorPage)
                    },
                     new Component {
                        Title = "Checkbox",
                        Description = "Cria uma caixa de marcação.",
                        Page = typeof(CheckboxPage)
                    },
                     new Component {
                        Title = "Radio Button",
                        Description = "Cria uma caixa de marcação de escolha única.",
                        Page = typeof(RadioButtonPage)
                    },
                     new Component {
                        Title = "Switch",
                        Description = "Caixa de marcação booleana.",
                        Page = typeof(SwitchPage)
                    },
                    new Component
                    {
                        Title = "Stepper",
                        Description = "Cria opções de incrementar ou decrementar um número.",
                        Page= typeof(StepperPage)
                    },
                     new Component {
                        Title = "Slider",
                        Description = "Cria uma barra para incrementar ou decrementar um número.",
                        Page = typeof(SliderPage)
                    },
                     new Component {
                        Title = "Time Picker",
                        Description = "Seleção da hora e minuto.",
                        Page = typeof(TimePickerPage)
                    },
                     new Component {
                        Title = "Date Picker",
                        Description = "Seleção da data.",
                        Page = typeof(DatePickerPage)
                    },
                     new Component {
                        Title = "Search Bar",
                        Description = "Campo de entrada de texto para pesquisa.",
                        Page = typeof(SearchBarPage)
                    },
                     new Component {
                        Title = "Picker",
                        Description = "Selecionar um item da lista.",
                        Page = typeof(PickerPage)
                    }
                }
            });

            return categories;
        }
    }
}
