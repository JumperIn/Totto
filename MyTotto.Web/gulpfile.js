var gulp = require("gulp"),
    fs = require("fs"),
    babel = require("gulp-babel"),
    cssmin = require('gulp-cssmin'),
    gulpif = require('gulp-if'),
    argv = require('yargs').argv,
    stylus = require("gulp-stylus"),
    gutil = require('gulp-util'),
    concat = require('gulp-concat'),
    livereload = require('gulp-livereload');

// пути исходников
var source = 'src';
var srcPaths = {
    stylus: [`./${source}/css/*.styl`],
    img: [`./${source}/img/**`],
    icons: [`./${source}/icons/**`],
    js: [`./${source}/scripts/*.js`],
    favicon: [`./${source}/favicon.ico`],
    fonts: [`./${source}/fonts/**`]
}

// пути для сборки
var destination = 'wwwroot';
var destPaths = {
    css: `./${destination}/css`,
    img: `./${destination}/images`,
    icons: `./${destination}/icons`,
    js: `./${destination}/js`,
    favicon: `./${destination}`,
    fonts: `./${destination}/fonts`
}

var production = argv.production !== undefined || argv.prod !== undefined;

// сборка стилей
gulp.task("stylus", function () {
    return gulp.src(srcPaths.stylus)
        .pipe(stylus())
        .pipe(gulp.dest(destPaths.css));
});

// сборка скриптов
gulp.task("js", function () {
    gulp.src(srcPaths.js)
        .pipe(babel({
            presets: [[
                'env', {
                    "targets": {
                        "browsers": [
                            "Chrome >= 52",
                            "FireFox >= 44",
                            "Safari >= 7",
                            "Explorer 11",
                            "last 4 Edge versions"
                        ]
                    },
                    "useBuiltIns": true
                }
            ]]
        }))
        .pipe(gulp.dest(destPaths.js));
});

// копирование ресурсов
gulp.task('copy', function () {
    gulp.src(srcPaths.icons)
        .pipe(gulp.dest(destPaths.icons));
    gulp.src(srcPaths.img)
        .pipe(gulp.dest(destPaths.img));
    gulp.src(srcPaths.fonts)
        .pipe(gulp.dest(destPaths.fonts));
});

gulp.task('favicon', function () {
    gulp.src(srcPaths.favicon)
        .pipe(gulp.dest(destPaths.favicon));
})

gulp.task('watch', function () {
    livereload.listen();
    gulp.watch(
        [ ...srcPaths.stylus, ...srcPaths.js, ...paths.icons, ...paths.img ],
        [ 'stylus', 'js', 'copy' ])
        .on('change', livereload.changed);
});

gulp.task('default', [
    'copy',
    'js',
    'stylus',
    'favicon'
]);
