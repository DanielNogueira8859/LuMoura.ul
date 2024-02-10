$(document).ready(function () {
    const daysTag = $(".days"),
        currentDate = $(".current-date"),
        prevNextIcon = $(".icons span");

    daysTag.on('click', 'li', function () {
        var dataSelecionada = $(this).text();
        console.log('Data selecionada:', dataSelecionada);

        // Enviar a data selecionada para o servidor (usando AJAX)
        $.ajax({
            type: "POST",
            url: '<%= ResolveUrl("~/Calendar.aspx/ArmazenarDataSelecionada") %>',
            data: JSON.stringify({ dataSelecionada: dataSelecionada }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log("Data armazenada com sucesso!");
            },
            error: function (error) {
                console.error("Erro ao armazenar a data:", error);

                // Adicione esta linha para ver a resposta do servidor no console
                console.log("Resposta do servidor:", error.responseText);
            }
        });
    });

    let date = new Date(),
        currYear = date.getFullYear(),
        currMonth = date.getMonth();

    const months = [
        "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
        "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
    ];

    const renderCalendar = () => {
        let firstDayofMonth = new Date(currYear, currMonth, 1).getDay(),
            lastDateofMonth = new Date(currYear, currMonth + 1, 0).getDate(),
            lastDayofMonth = new Date(currYear, currMonth, lastDateofMonth).getDay(),
            lastDateofLastMonth = new Date(currYear, currMonth, 0).getDate();
        let liTag = "";

        for (let i = firstDayofMonth; i > 0; i--) {
            liTag += `<li class="inactive">${lastDateofLastMonth - i + 1}</li>`;
        }

        for (let i = 1; i <= lastDateofMonth; i++) {
            let isToday = i === date.getDate() && currMonth === date.getMonth() && currYear === date.getFullYear() ? "active" : "";
            liTag += `<li class="${isToday}">${i}</li>`;
        }

        for (let i = lastDayofMonth; i < 6; i++) {
            liTag += `<li class="inactive">${i - lastDayofMonth + 1}</li>`;
        }

        currentDate.text(`${months[currMonth]} ${currYear}`);
        daysTag.html(liTag);

        // Adicione ouvintes de evento diretamente nos itens da lista
        daysTag.find("li").on("click", function () {
            // Remova a classe 'selected-item' de todos os itens
            daysTag.find("li").removeClass("selected-item");

            // Adicione a classe 'selected-item' ao item clicado
            $(this).addClass("selected-item");
        });
    };

    const initCalendar = () => {
        renderCalendar();

        prevNextIcon.on("click", function () {
            currMonth = this.id === "prev" ? currMonth - 1 : currMonth + 1;

            if (currMonth < 0 || currMonth > 11) {
                date.setFullYear(currYear, currMonth);
                currYear = date.getFullYear();
                currMonth = date.getMonth();
            } else {
                date = new Date();
            }
            renderCalendar();
        });
    };

    initCalendar();
});
